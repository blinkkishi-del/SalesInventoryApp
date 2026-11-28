INSERT INTO [dbo].[tblUsers] (Username, Password, Role)
VALUES


('Leona','leona2', 'Cashier'),
('Patrick','patrick2', 'Cashier'),
('Kharl','kharl2', 'Cashier'),
('Ericka','ericka2', 'Cashier'),
('Ariello','ariello1','Admin'),
('Jelyn','jelyn1', 'Admin');

GO

INSERT INTO [dbo].[tblCategory] (CategoryName)
VALUES
('Refrigeration'), ('Laundry'), ('Air Conditioning'), ('TV & Audio'), ('Cooking Appliances'), ('Kitchen Appliances'),
('Small Appliances'), ('Cleaning Appliances'), ('Air Care'), ('Fans & Ventilation'), ('Water Heating'), ('Personal Care'),
('Home Essentials');

GO

INSERT INTO [dbo].[tblBrand] (BrandName)
VALUES
('LG'), ('Samsung'), ('Whirlpool'), ('Daikin'), ('Carrier'), ('Sony'),
('Panasonic'), ('Elba'), ('La Germania'), ('Zojirushi'), ('Dyson'), ('Xiaomi'),
('Hanabishi'), ('Philips'), ('De''Longhi'), ('Breville'), ('KitchenAid'), ('Oster'),
('Bosch'), ('Fujidenzo'), ('Condura'), ('Asahi'), ('Camel'), ('Tefal'),
('KDK'), ('Roborock'), ('JBL'), ('Sharp'), ('Cuisinart'), ('Imarflex'),
('George Foreman'), ('Hurom'), ('Dowell'), ('Firefly'), ('Muji'), ('Bissell');

GO

INSERT INTO [dbo].[tblSupplier] (SupplierId, SupplierName, Address, ContactPerson, PhoneNumber, EmailAddress)
VALUES
('SUP-001', 'Luzon Home Appliance Dist.', '1180 EDSA, Balintawak, Quezon City', 'Marco Villanueva', '(02) 8361-4410', 'orders@luzonhomeappliance.ph'),
('SUP-002', 'Metro Manila Cooling Corp.', '25 Pioneer St., Mandaluyong City', 'Jenny Ramos', '(02) 8634-2207', 'sales@mmcooling.ph'),
('SUP-003', 'Pacific Electronics Trading', '7F Ortigas Tower, Ortigas Ave., Pasig City', 'Carlo Dizon', '(02) 8706-1193', 'trade@pacificce.ph'),
('SUP-004', 'KusinaPro Appliance Supply', '88 Kalayaan Ave., Makati City', 'Liza Fernandez', '0917-842-3301', 'purchasing@kusinapro.ph'),
('SUP-005', 'Pinoy Housewares Wholesale', '412 Soler St., Binondo, Manila', 'Noel Santos', '(02) 8241-5528', 'wholesale@pinoyhousewares.ph'),
('SUP-006', 'SmartNest Tech Distribution', '3F Uptown Place, BGC, Taguig City', 'Grace Lim', '0918-224-7710', 'b2b@smartnest.ph'),
('SUP-007', 'ProClean Home Care Trading', '56 Shaw Blvd., Pasig City', 'Ramon Cruz', '0917-503-9182', 'orders@procleanhomecare.ph'),
('SUP-008', 'PowerSafe Electrical Supply', '19 Rizal Ave. Ext., Caloocan City', 'Bea Mendoza', '(02) 8287-6634', 'sales@powersafe.ph'),
('SUP-009', 'EuroHome Appliance Imports', '2F Alabang Corporate Center, Muntinlupa City', 'Victor Ocampo', '(02) 8809-3345', 'imports@eurohome.ph');

GO

INSERT INTO [dbo].[tblProduct] (ProductId, ProductName, Model, Brand, Category, Supplier, Quantity, Amount)
VALUES
('APP-001', 'Inverter Side-by-Side Refrigerator 22 cu.ft', 'GR-X257CQES', 'LG', 'Refrigeration', 'Luzon Home Appliance Dist.', 22, 89995.00),
('APP-002', 'Front-Load Inverter Washing Machine 9kg', 'WW90T504DAX', 'Samsung', 'Laundry', 'Luzon Home Appliance Dist.', 25, 34995.00),
('APP-003', 'Heat Pump Clothes Dryer 8kg', 'HSCX 80531', 'Whirlpool', 'Laundry', 'EuroHome Appliance Imports', 28, 52995.00),
('APP-004', 'Split-Type Inverter Air Conditioner 1.5HP', 'FTKF35CVM', 'Daikin', 'Air Conditioning', 'Metro Manila Cooling Corp.', 26, 42900.00),
('APP-005', 'Window-Type Inverter Air Conditioner 1HP', 'WCARZ010EC', 'Carrier', 'Air Conditioning', 'Metro Manila Cooling Corp.', 21, 24998.00),
('APP-006', 'BRAVIA 55-Inch 4K Google TV', 'KD-55X80L', 'Sony', 'TV & Audio', 'Pacific Electronics Trading', 18, 46999.00),
('APP-007', 'Inverter Microwave Oven 27L', 'NN-ST34NBPQ', 'Panasonic', 'Cooking Appliances', 'Pacific Electronics Trading', 24, 6495.00),
('APP-008', '4-Burner Gas Range with Electric Oven', 'EGR 6002', 'Elba', 'Cooking Appliances', 'Pinoy Housewares Wholesale', 24, 28500.00),
('APP-009', 'Built-in Chimney Range Hood 90cm', 'H-90X', 'La Germania', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 17, 11200.00),
('APP-010', 'Micom Fuzzy Logic Rice Cooker 1L', 'NS-TSQ10', 'Zojirushi', 'Small Appliances', 'KusinaPro Appliance Supply', 27, 9800.00),
('APP-011', 'V12 Detect Slim Cordless Vacuum', 'SV46', 'Dyson', 'Cleaning Appliances', 'ProClean Home Care Trading', 15, 39900.00),
('APP-012', 'Smart Air Purifier 4', 'AC-M16-SC', 'Xiaomi', 'Air Care', 'SmartNest Tech Distribution', 23, 7499.00),
('APP-013', 'Electric Convection Oven 45L', 'HEO-45PSS', 'Hanabishi', 'Cooking Appliances', 'Pinoy Housewares Wholesale', 20, 5200.00),
('APP-014', 'Essential Air Fryer XL 6.2L', 'HD9270/91', 'Philips', 'Small Appliances', 'KusinaPro Appliance Supply', 5, 6995.00),
('APP-015', 'Dedica Pump Espresso Machine', 'EC685.M', 'De''Longhi', 'Small Appliances', 'KusinaPro Appliance Supply', 16, 21990.00),
('APP-016', 'Smart Kettle Stainless Steel 1.7L', 'BKE830BSS', 'Breville', 'Small Appliances', 'KusinaPro Appliance Supply', 29, 3850.00),
('APP-017', '4-Slice Pop-Up Toaster', 'KMT4115', 'KitchenAid', 'Small Appliances', 'KusinaPro Appliance Supply', 28, 7495.00),
('APP-018', 'Pro 1200 Countertop Blender', 'BLSTMB-CBG', 'Oster', 'Small Appliances', 'KusinaPro Appliance Supply', 25, 5495.00),
('APP-019', 'Artisan Tilt-Head Stand Mixer 4.8L', '5KSM175PS', 'KitchenAid', 'Small Appliances', 'KusinaPro Appliance Supply', 12, 32995.00),
('APP-020', 'Serie 4 Free-Standing Dishwasher', 'SMS4HVI33E', 'Bosch', 'Kitchen Appliances', 'EuroHome Appliance Imports', 23, 42500.00),
('APP-021', 'Hot & Cold Water Dispenser', 'FWD-1036', 'Fujidenzo', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 7, 8995.00),
('APP-022', 'Inverter Chest Freezer 7 cu.ft', 'CCF200Ri', 'Condura', 'Refrigeration', 'Metro Manila Cooling Corp.', 27, 17995.00),
('APP-023', '16-Inch Stand Fan', 'SF-6390', 'Asahi', 'Fans & Ventilation', 'Pinoy Housewares Wholesale', 30, 1995.00),
('APP-024', '20-Inch Industrial Floor Fan', 'CF-20', 'Camel', 'Fans & Ventilation', 'Pinoy Housewares Wholesale', 22, 2890.00),
('APP-025', 'Ultragliss Steam Iron', 'FV4997', 'Tefal', 'Laundry', 'ProClean Home Care Trading', 8, 3495.00),
('APP-026', 'Standing Garment Steamer', 'STE3170/86', 'Philips', 'Laundry', 'ProClean Home Care Trading', 19, 4995.00),
('APP-027', 'Multipoint Instant Water Heater', 'DH-6RL1PW', 'Panasonic', 'Water Heating', 'PowerSafe Electrical Supply', 26, 9800.00),
('APP-028', 'Ceiling Mount Exhaust Fan 8-Inch', '20CHH', 'KDK', 'Fans & Ventilation', 'PowerSafe Electrical Supply', 28, 1850.00),
('APP-029', 'Supersonic Hair Dryer', 'HD08', 'Dyson', 'Personal Care', 'ProClean Home Care Trading', 9, 24900.00),
('APP-030', 'Q7 Max+ Robot Vacuum and Mop', 'Q7M52-02', 'Roborock', 'Cleaning Appliances', 'SmartNest Tech Distribution', 14, 29990.00),
('APP-031', 'Bar 500 Soundbar with Subwoofer', 'JBLBAR500PRO', 'JBL', 'TV & Audio', 'Pacific Electronics Trading', 13, 34995.00),
('APP-032', 'Dehumidifier 12L', 'DW-D12A-W', 'Sharp', 'Air Care', 'Pacific Electronics Trading', 17, 13995.00),
('APP-033', 'Serie 4 Built-in Electric Oven 66L', 'HBF133BS0', 'Bosch', 'Cooking Appliances', 'EuroHome Appliance Imports', 14, 24995.00),
('APP-034', '14-Cup Food Processor', 'DFP-14BCNY', 'Cuisinart', 'Small Appliances', 'KusinaPro Appliance Supply', 8, 13995.00),
('APP-035', 'Induction Cooker 2000W', 'IDX-2000T', 'Imarflex', 'Cooking Appliances', 'Pinoy Housewares Wholesale', 30, 2795.00),
('APP-036', 'Electric Grill & Panini Press', 'GR340FB', 'George Foreman', 'Small Appliances', 'KusinaPro Appliance Supply', 21, 3600.00),
('APP-037', 'Cold Press Slow Juicer', 'H310A', 'Hurom', 'Small Appliances', 'KusinaPro Appliance Supply', 18, 16500.00),
('APP-038', 'Wine Chiller 12 Bottles', 'FWC-12', 'Fujidenzo', 'Refrigeration', 'Pinoy Housewares Wholesale', 30, 15995.00),
('APP-039', 'Plasmacluster Air Purifier', 'FP-J30E-A', 'Sharp', 'Air Care', 'Pacific Electronics Trading', 26, 6995.00),
('APP-040', 'Daily Collection Hand Blender', 'HR1600/00', 'Philips', 'Small Appliances', 'KusinaPro Appliance Supply', 29, 2295.00),
('APP-041', 'Electric Pressure Multicooker 4.8L', 'CY601D', 'Tefal', 'Cooking Appliances', 'KusinaPro Appliance Supply', 19, 8995.00),
('APP-042', 'Automatic Bread Maker', 'SD-P104', 'Panasonic', 'Small Appliances', 'Pacific Electronics Trading', 16, 7995.00),
('APP-043', 'Styler Steam Clothing Care System', 'S3RF', 'LG', 'Laundry', 'Luzon Home Appliance Dist.', 11, 89995.00),
('APP-044', 'UV-C Dish Sterilizer & Dryer', 'DS-60', 'Dowell', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 23, 4895.00),
('APP-045', 'Electric Insect Killer Lamp', 'FIK-901', 'Firefly', 'Home Essentials', 'Pinoy Housewares Wholesale', 27, 1250.00),
('APP-046', 'Ultrasonic Aroma Diffuser', 'MJ-AD1', 'Muji', 'Air Care', 'SmartNest Tech Distribution', 25, 2950.00),
('APP-047', 'SpotClean Pro Upholstery Cleaner', '3624', 'Bissell', 'Cleaning Appliances', 'ProClean Home Care Trading', 16, 12995.00),
('APP-048', 'Portable Ice Maker 12kg', 'FIM-12', 'Fujidenzo', 'Refrigeration', 'Pinoy Housewares Wholesale', 20, 9995.00),
('APP-049', 'Purifier Cool Tower Fan', 'TP07', 'Dyson', 'Air Care', 'ProClean Home Care Trading', 15, 32900.00),
('APP-050', 'Bespoke Jet Cordless Vacuum', 'VS20A95823W', 'Samsung', 'Cleaning Appliances', 'ProClean Home Care Trading', 18, 34995.00);

GO


INSERT INTO [dbo].[tblProductDetails] (ProductId, Category, Supplier, Name)
VALUES
('APP-001', 'Refrigeration', 'Luzon Home Appliance Dist.', 'Inverter Side-by-Side Refrigerator 22 cu.ft'),
('APP-002', 'Laundry', 'Luzon Home Appliance Dist.', 'Front-Load Inverter Washing Machine 9kg'),
('APP-003', 'Laundry', 'EuroHome Appliance Imports', 'Heat Pump Clothes Dryer 8kg'),
('APP-004', 'Air Conditioning', 'Metro Manila Cooling Corp.', 'Split-Type Inverter Air Conditioner 1.5HP'),
('APP-005', 'Air Conditioning', 'Metro Manila Cooling Corp.', 'Window-Type Inverter Air Conditioner 1HP'),
('APP-006', 'TV & Audio', 'Pacific Electronics Trading', 'BRAVIA 55-Inch 4K Google TV'),
('APP-007', 'Cooking Appliances', 'Pacific Electronics Trading', 'Inverter Microwave Oven 27L'),
('APP-008', 'Cooking Appliances', 'Pinoy Housewares Wholesale', '4-Burner Gas Range with Electric Oven'),
('APP-009', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 'Built-in Chimney Range Hood 90cm'),
('APP-010', 'Small Appliances', 'KusinaPro Appliance Supply', 'Micom Fuzzy Logic Rice Cooker 1L'),
('APP-011', 'Cleaning Appliances', 'ProClean Home Care Trading', 'V12 Detect Slim Cordless Vacuum'),
('APP-012', 'Air Care', 'SmartNest Tech Distribution', 'Smart Air Purifier 4'),
('APP-013', 'Cooking Appliances', 'Pinoy Housewares Wholesale', 'Electric Convection Oven 45L'),
('APP-014', 'Small Appliances', 'KusinaPro Appliance Supply', 'Essential Air Fryer XL 6.2L'),
('APP-015', 'Small Appliances', 'KusinaPro Appliance Supply', 'Dedica Pump Espresso Machine'),
('APP-016', 'Small Appliances', 'KusinaPro Appliance Supply', 'Smart Kettle Stainless Steel 1.7L'),
('APP-017', 'Small Appliances', 'KusinaPro Appliance Supply', '4-Slice Pop-Up Toaster'),
('APP-018', 'Small Appliances', 'KusinaPro Appliance Supply', 'Pro 1200 Countertop Blender'),
('APP-019', 'Small Appliances', 'KusinaPro Appliance Supply', 'Artisan Tilt-Head Stand Mixer 4.8L'),
('APP-020', 'Kitchen Appliances', 'EuroHome Appliance Imports', 'Serie 4 Free-Standing Dishwasher'),
('APP-021', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 'Hot & Cold Water Dispenser'),
('APP-022', 'Refrigeration', 'Metro Manila Cooling Corp.', 'Inverter Chest Freezer 7 cu.ft'),
('APP-023', 'Fans & Ventilation', 'Pinoy Housewares Wholesale', '16-Inch Stand Fan'),
('APP-024', 'Fans & Ventilation', 'Pinoy Housewares Wholesale', '20-Inch Industrial Floor Fan'),
('APP-025', 'Laundry', 'ProClean Home Care Trading', 'Ultragliss Steam Iron'),
('APP-026', 'Laundry', 'ProClean Home Care Trading', 'Standing Garment Steamer'),
('APP-027', 'Water Heating', 'PowerSafe Electrical Supply', 'Multipoint Instant Water Heater'),
('APP-028', 'Fans & Ventilation', 'PowerSafe Electrical Supply', 'Ceiling Mount Exhaust Fan 8-Inch'),
('APP-029', 'Personal Care', 'ProClean Home Care Trading', 'Supersonic Hair Dryer'),
('APP-030', 'Cleaning Appliances', 'SmartNest Tech Distribution', 'Q7 Max+ Robot Vacuum and Mop'),
('APP-031', 'TV & Audio', 'Pacific Electronics Trading', 'Bar 500 Soundbar with Subwoofer'),
('APP-032', 'Air Care', 'Pacific Electronics Trading', 'Dehumidifier 12L'),
('APP-033', 'Cooking Appliances', 'EuroHome Appliance Imports', 'Serie 4 Built-in Electric Oven 66L'),
('APP-034', 'Small Appliances', 'KusinaPro Appliance Supply', '14-Cup Food Processor'),
('APP-035', 'Cooking Appliances', 'Pinoy Housewares Wholesale', 'Induction Cooker 2000W'),
('APP-036', 'Small Appliances', 'KusinaPro Appliance Supply', 'Electric Grill & Panini Press'),
('APP-037', 'Small Appliances', 'KusinaPro Appliance Supply', 'Cold Press Slow Juicer'),
('APP-038', 'Refrigeration', 'Pinoy Housewares Wholesale', 'Wine Chiller 12 Bottles'),
('APP-039', 'Air Care', 'Pacific Electronics Trading', 'Plasmacluster Air Purifier'),
('APP-040', 'Small Appliances', 'KusinaPro Appliance Supply', 'Daily Collection Hand Blender'),
('APP-041', 'Cooking Appliances', 'KusinaPro Appliance Supply', 'Electric Pressure Multicooker 4.8L'),
('APP-042', 'Small Appliances', 'Pacific Electronics Trading', 'Automatic Bread Maker'),
('APP-043', 'Laundry', 'Luzon Home Appliance Dist.', 'Styler Steam Clothing Care System'),
('APP-044', 'Kitchen Appliances', 'Pinoy Housewares Wholesale', 'UV-C Dish Sterilizer & Dryer'),
('APP-045', 'Home Essentials', 'Pinoy Housewares Wholesale', 'Electric Insect Killer Lamp'),
('APP-046', 'Air Care', 'SmartNest Tech Distribution', 'Ultrasonic Aroma Diffuser'),
('APP-047', 'Cleaning Appliances', 'ProClean Home Care Trading', 'SpotClean Pro Upholstery Cleaner'),
('APP-048', 'Refrigeration', 'Pinoy Housewares Wholesale', 'Portable Ice Maker 12kg'),
('APP-049', 'Air Care', 'ProClean Home Care Trading', 'Purifier Cool Tower Fan'),
('APP-050', 'Cleaning Appliances', 'ProClean Home Care Trading', 'Bespoke Jet Cordless Vacuum');

GO