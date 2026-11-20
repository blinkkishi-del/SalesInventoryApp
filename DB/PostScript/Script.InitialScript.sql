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

-- [ KITCHEN ] (19)
('HA1001', 'Air Fryer 5L', 'Kitchen', 'NinjaCorp', 120, 129.99),
('HA1002', 'Smart Inverter Fridge', 'Kitchen', 'Apex Appliances', 35, 899.00),
('HA1005', 'Electric Pressure Cooker', 'Kitchen', 'InstantHome', 150, 89.99),
('HA1008', '12-Cup Coffee Maker', 'Kitchen', 'BrewMaster', 110, 49.99),
('HA1010', 'Convection Microwave', 'Kitchen', 'Apex Appliances', 70, 179.99),
('HA1013', 'Countertop Ice Maker', 'Kitchen', 'ChillTech', 85, 119.99),
('HA1014', 'High-Speed Blender', 'Kitchen', 'VitaMixer', 90, 159.50),
('HA1019', 'Food Processor 8-Cup', 'Kitchen', 'NinjaCorp', 115, 89.99),
('HA1020', 'Toaster 4-Slice', 'Kitchen', 'BrewMaster', 160, 39.99),
('HA1022', 'Electric Kettle 1.7L', 'Kitchen', 'ChillTech', 220, 34.99),
('HA1023', 'Water Dispenser', 'Kitchen', 'AquaPure', 45, 139.99),
('HA1024', 'Multi-Cooker Rice Cooker', 'Kitchen', 'InstantHome', 175, 74.50),
('HA1026', 'Hand Mixer', 'Kitchen', 'BrewMaster', 210, 24.99),
('HA1027', 'Garlic Chopper Mini', 'Kitchen', 'NinjaCorp', 350, 19.99),
('HA1028', 'Electric Griddle', 'Kitchen', 'Apex Appliances', 95, 49.99),
('HA1029', 'Deep Fryer 3L', 'Kitchen', 'ChillTech', 65, 69.99),
('HA1030', 'Stick Immersion Blender', 'Kitchen', 'VitaMixer', 140, 39.99),
('HA1031', 'Espresso Machine', 'Kitchen', 'BrewMaster', 55, 299.99),
('HA1037', 'Mini Fridge 4L', 'Kitchen', 'Apex Appliances', 75, 49.99),
('HA1038', 'Panini Press Grill', 'Kitchen', 'NinjaCorp', 100, 59.99),
('HA1039', 'Waffle Maker', 'Kitchen', 'BrewMaster', 120, 34.99),
('HA1040', 'Portable Induction Cooktop', 'Kitchen', 'InstantHome', 90, 79.99),
('HA1041', 'Stand Mixer 5Qt', 'Kitchen', 'VitaMixer', 40, 229.99),
('HA1042', 'Wine Cooler 18-Bottle', 'Kitchen', 'ChillTech', 30, 249.99),
('HA1043', 'Dishwasher Built-In', 'Kitchen', 'Whirlwind', 20, 480.00),
('HA1045', 'Upright Freezer', 'Kitchen', 'Apex Appliances', 25, 399.99),

-- [ CLEANING ] (5)
('HA1003', 'Cordless Stick Vacuum', 'Cleaning', 'DysonTech', 80, 249.50),
('HA1007', 'Robotic Vacuum Cleaner', 'Cleaning', 'RoboClean', 60, 329.00),
('HA1046', 'Carpet Cleaner', 'Cleaning', 'RoboClean', 45, 189.99),
('HA1047', 'Handheld Vacuum', 'Cleaning', 'DysonTech', 110, 79.99),

-- [ LAUNDRY ] (4)
('HA1004', 'Front-Load Washer', 'Laundry', 'Whirlwind', 25, 650.00),
('HA1011', 'Steam Iron', 'Laundry', 'PressPro', 200, 35.00),
('HA1015', 'Clothes Dryer', 'Laundry', 'Whirlwind', 30, 599.99),
('HA1021', 'Handheld Garment Steamer', 'Laundry', 'PressPro', 180, 45.00),

-- [ CLIMATE ] (7)
('HA1006', 'HEPA Air Purifier', 'Climate', 'PureAir Inc.', 95, 149.99),
('HA1009', 'Tower Fan with Remote', 'Climate', 'BreezeCo', 140, 65.00),
('HA1012', 'Dehumidifier 50-Pint', 'Climate', 'PureAir Inc.', 40, 219.99),
('HA1018', 'Portable Space Heater', 'Climate', 'WarmthCo', 130, 59.99),
('HA1025', 'Window AC Unit 10000BTU', 'Climate', 'BreezeCo', 50, 349.00),
('HA1034', 'Electric Blanket', 'Climate', 'WarmthCo', 110, 69.99),
('HA1035', 'Humidifier Ultrasonic', 'Climate', 'PureAir Inc.', 130, 49.99),
('HA1036', 'Smart Thermostat', 'Climate', 'EcoHome', 85, 129.99),

-- [ PERSONAL CARE ] (5)
('HA1016', 'Ceramic Hair Straightener', 'Personal Care', 'GlamourTech', 250, 29.99),
('HA1017', 'Electric Toothbrush', 'Personal Care', 'SmileCare', 300, 49.99),
('HA1032', 'Sonic Facial Cleanser', 'Personal Care', 'GlamourTech', 190, 39.99),
('HA1033', 'Hair Dryer Pro', 'Personal Care', 'GlamourTech', 160, 54.99),
('HA1044', 'Electric Toothbrush Kids', 'Personal Care', 'SmileCare', 240, 24.99),

-- [ OUTDOOR ] (3)
('HA1048', 'Electric Lawn Mower', 'Outdoor', 'GreenYard', 15, 299.00),
('HA1049', 'Leaf Blower Cordless', 'Outdoor', 'GreenYard', 50, 119.00),
('HA1050', 'Electric Pressure Washer', 'Outdoor', 'CleanMax', 40, 159.99);

GO


INSERT INTO [dbo].[tblProductDetails] (ProductId, Category, Supplier, Name)
VALUES

('9X4R6T', 'Notebooks', 'Sterling Paper Products Enterprises, Inc.', 'Spiral Notebook 80 Sheets');

GO


