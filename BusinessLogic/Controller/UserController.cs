using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        public static readonly string[] Roles = { "Admin", "Cashier" };

        public const int MaxFailedAttempts = 5;
        public static readonly TimeSpan LockoutDuration = TimeSpan.FromMinutes(5);

        private static readonly Dictionary<string, (int Failures, DateTime LockedUntil)> loginAttempts =
            new Dictionary<string, (int, DateTime)>(StringComparer.OrdinalIgnoreCase);
        private static readonly object attemptsLock = new object();

        private UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        public UserModel Login(string username, string password)
        {
            username = username?.Trim() ?? "";
            ThrowIfLockedOut(username);

            var user = userRepository.GetByUsername(username);
            if (user == null || !string.Equals(password, user.Password, StringComparison.Ordinal))
            {
                RecordFailure(username);
                return null;
            }

            lock (attemptsLock) loginAttempts.Remove(username);
            user.Password = null;
            if (!user.IsActive)
                throw new InvalidOperationException("This account is deactivated. Please contact an Admin.");
            return user;
        }

        private static void ThrowIfLockedOut(string username)
        {
            lock (attemptsLock)
            {
                if (loginAttempts.TryGetValue(username, out var a) && a.LockedUntil > DateTime.Now)
                {
                    int minutes = (int)Math.Ceiling((a.LockedUntil - DateTime.Now).TotalMinutes);
                    throw new InvalidOperationException(
                        $"Too many failed login attempts. Try again in {minutes} minute(s).");
                }
            }
        }

        private static void RecordFailure(string username)
        {
            lock (attemptsLock)
            {
                loginAttempts.TryGetValue(username, out var a);
                int failures = a.Failures + 1;
                loginAttempts[username] = failures >= MaxFailedAttempts
                    ? (0, DateTime.Now + LockoutDuration)
                    : (failures, DateTime.MinValue);
            }
        }

        public List<string> GetCashierUsernames() => userRepository.GetUsernamesByRole("Cashier");

        public List<UserModel> GetAllUsers() => userRepository.GetAll();

        public void Add(UserModel user, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(user.Username)) throw new Exception("Username cannot be empty.");
            if (string.IsNullOrWhiteSpace(user.FullName)) throw new Exception("Full name cannot be empty.");
            if (!Roles.Contains(user.Role)) throw new Exception("Please select a role.");
            ValidateNewPassword(user.Password, confirmPassword);

            user.Username = user.Username.Trim();
            user.FullName = user.FullName.Trim();
            userRepository.AddUser(user);
        }

        public void SetActive(string username, bool isActive, string currentUsername)
        {
            if (!isActive && username == currentUsername)
                throw new Exception("You cannot deactivate the account you are logged in with.");
            userRepository.SetActive(username, isActive);
        }

        public void ChangePassword(string username, string currentPassword, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(currentPassword)) throw new Exception("Please enter your current password.");
            ValidateNewPassword(newPassword, confirmPassword);
            if (newPassword == currentPassword) throw new Exception("The new password must be different from the current one.");
            var user = userRepository.GetByUsername(username);
            if (user == null || !string.Equals(currentPassword, user.Password, StringComparison.Ordinal))
                throw new InvalidOperationException("Current password is incorrect.");
            userRepository.SetPassword(username, newPassword);
        }

        public void ResetPassword(string username, string newPassword, string confirmPassword)
        {
            ValidateNewPassword(newPassword, confirmPassword);
            userRepository.SetPassword(username, newPassword);
        }

        private static void ValidateNewPassword(string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 50)
                throw new Exception("Password must be 8 to 50 characters long.");
            if (password.Any(char.IsWhiteSpace))
                throw new Exception("Password cannot contain spaces.");
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                throw new Exception("Password must contain an uppercase letter, a lowercase letter and a number.");
            if (password != confirmPassword)
                throw new Exception("Passwords do not match.");
        }
    }
}
