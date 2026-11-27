INSERT INTO [dbo].[tblUsers] (Username, Password, Role)
VALUES 


('Andrey','qwertyuiop', 'Cashier'),
('Leona','kakarot', 'Cashier'),
('Aiko','onepiece', 'Cashier'),
('John','bleach', 'Cashier'),
('Patrick','dragonball','Admin'),
('Alexis','naruto', 'Admin');

GO

-- 50 Records
INSERT INTO [dbo].[tblProduct] (ProductId, ProductName, Category, Supplier, Quantity, Amount)
VALUES
('APP-001', 'Inverter Side-by-Side Refrigerator', 'Kitchen', 'LG Electronics', 22, 48500.00),
('APP-002', 'Front-Load Washing Machine', 'Laundry Room', 'Samsung Electronics', 25, 26995.00),
('APP-003', 'Heat Pump Clothes Dryer', 'Laundry Room', 'Whirlpool', 28, 32400.00),
('APP-004', 'Double-Type Inverter Air Conditioner', 'Master Bedroom', 'Daikin', 26, 34800.00),
('APP-005', 'Split-Type Inverter Air Conditioner', 'Living Room', 'Carrier', 21, 42500.00),
('APP-006', '55-Inch Smart QLED TV', 'Living Room', 'Sony', 33, 38990.00),
('APP-007', 'Digital Microwave Oven', 'Kitchen', 'Panasonic', 46, 6495.00),
('APP-008', '4-Burner Gas Range with Electric Oven', 'Kitchen', 'Elba', 24, 28500.00),
('APP-009', 'Built-in Range Hood', 'Kitchen', 'La Germania', 36, 11200.00),
('APP-010', 'Digital Fuzzy Rice Cooker', 'Kitchen', 'Zojirushi', 54, 9800.00),
('APP-011', 'Cordless Stick Vacuum Cleaner', 'Living Room / All Areas', 'Dyson', 52, 24900.00),
('APP-012', 'HEPA Air Purifier', 'Master Bedroom', 'Xiaomi', 45, 7499.00),
('APP-013', 'Electric Convection Oven', 'Kitchen', 'Hanabishi', 41, 5200.00),
('APP-014', 'Digital Air Fryer', 'Kitchen', 'Philips', 5, 6995.00),
('APP-015', 'Espresso & Cappuccino Maker', 'Kitchen / Dining', 'De''Longhi', 44, 14500.00),
('APP-016', 'Stainless Steel Electric Kettle', 'Kitchen', 'Breville', 63, 3850.00),
('APP-017', '4-Slice Pop-Up Toaster', 'Kitchen', 'KitchenAid', 61, 4200.00),
('APP-018', 'High-Speed Countertop Blender', 'Kitchen', 'Oster', 55, 3495.00),
('APP-019', 'Stand Mixer with Stainless Bowl', 'Kitchen', 'KitchenAid', 38, 27900.00),
('APP-020', 'Free-Standing Dishwasher', 'Kitchen', 'Bosch', 23, 35000.00),
('APP-021', 'Water Dispenser', 'Dining Room', 'Fujidenzo', 7, 8995.00),
('APP-022', 'Chest Freezer', 'Utility / Storage Room', 'Condura', 27, 14200.00),
('APP-023', '16-Inch Inverter Stand Fan', 'Living Room / Bedroom', 'Asahi', 47, 2650.00),
('APP-024', 'High-Velocity Industrial Floor Fan', 'Garage / Patio', 'Camel', 37, 2890.00),
('APP-025', 'Steam Iron with Ceramic Soleplate', 'Laundry Room', 'Tefal', 8, 2450.00),
('APP-026', 'Standing Garment Steamer', 'Walk-in Closet / Laundry', 'Philips', 48, 4995.00),
('APP-027', 'Multipoint Instant Water Heater', 'Master Bathroom', 'Panasonic', 56, 7800.00),
('APP-028', 'Ceiling Exhaust Fan', 'Bathroom', 'KDK', 58, 1850.00),
('APP-029', 'Ionic Hair Dryer', 'Master Bathroom', 'Dyson', 9, 21500.00),
('APP-030', 'Robot Vacuum and Mop Combo', 'Living Room / Hallways', 'Roborock', 51, 19990.00),
('APP-031', 'Soundbar with Wireless Subwoofer', 'Living Room', 'JBL', 39, 15495.00),
('APP-032', 'Dehumidifier', 'Basement / Bedroom', 'Carrier', 35, 12800.00),
('APP-033', 'Pressure Washer', 'Garage / Driveway', 'Bosch', 42, 8450.00),
('APP-034', 'Food Processor', 'Kitchen', 'Cuisinart', 8, 8900.00),
('APP-035', 'Induction Cooker', 'Kitchen', 'Imarflex', 62, 2795.00),
('APP-036', 'Electric Grill & Panini Press', 'Kitchen / Dining', 'George Foreman', 53, 3600.00),
('APP-037', 'Cold Press Slow Juicer', 'Kitchen', 'Hurom', 47, 16500.00),
('APP-038', 'Wine Chiller', 'Dining Room', 'Fujidenzo', 30, 15995.00),
('APP-039', 'Smart Video Doorbell', 'Front Entrance', 'Ring', 70, 6500.00),
('APP-040', 'Indoor Pan-Tilt Security Camera', 'Living Room / Hallway', 'TP-Link Tapo', 68, 1499.00),
('APP-041', 'Automatic Voltage Regulator', 'Living Room / Home Office', 'Meiji', 43, 2150.00),
('APP-042', 'Uninterruptible Power Supply', 'Home Office', 'APC', 40, 5400.00),
('APP-043', 'Paper Shredder', 'Home Office', 'Fellowes', 46, 4350.00),
('APP-044', 'UV-C Dish Sterilizer & Dryer', 'Kitchen', 'Dowell', 44, 4895.00),
('APP-045', 'Insect Killer Lamp', 'Dining Room / Kitchen', 'Firefly', 64, 1250.00),
('APP-046', 'Aroma Diffuser & Humidifier', 'Bedroom', 'Muji', 67, 2950.00),
('APP-047', 'Handheld Upholstery Cleaner', 'Living Room / Bedroom', 'Bissell', 57, 7995.00),
('APP-048', 'Portable Ice Maker', 'Kitchen / Home Bar', 'Breville', 36, 11500.00),
('APP-049', 'Smart Wi-Fi Mesh Router', 'All Areas', 'TP-Link Deco', 65, 8990.00),
('APP-050', 'Electric Lawn Trimmer', 'Garden / Yard', 'Black+Decker', 48, 3450.00);

GO


INSERT INTO [dbo].[tblProductDetails] (ProductId, Category, Supplier, Name)
VALUES

('APP-050', 'Garden / Yard', 'Black+Decker', 'Electric Lawn Trimmer');

GO