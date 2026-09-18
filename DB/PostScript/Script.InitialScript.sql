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

-- [ PENCILS ] (6)
('K79X2M', 'Mongol 1', 'Pencils', 'Amspec Fine Products Inc.', 102, 10.00),
('P4W8Q1', 'Mongol 2', 'Pencils', 'Amspec Fine Products Inc.', 250, 10.00),
('9F3V7L', 'Mongol 3', 'Pencils', 'Amspec Fine Products Inc.', 180, 10.00),
('R2M6K8', 'Faber-Castell 2B Pencil', 'Pencils', 'Amspec Fine Products Inc.', 120, 15.00),
('3J8H5N', 'Pilot Mechanical Pencil 0.5', 'Pencils', 'Penline Stationery Inc.', 75, 45.00),
('X9B4T2', 'HB Graphite Pencil Set', 'Pencils', 'Goldwings Stationery Products Inc.', 60, 85.00),



-- [ PENS ] (7)
('8N2D6P', 'Pilot G2 Gel Pen Black 0.7', 'Pens', 'Penline Stationery Inc.', 150, 65.00),
('V4K9X3', 'Pilot G2 Gel Pen Blue 0.7', 'Pens', 'Penline Stationery Inc.', 140, 65.00),
('1M7F5J', 'Pilot G2 Gel Pen Red 0.7', 'Pens', 'Penline Stationery Inc.', 90, 65.00),
('Q3R8W2', 'Faber-Castell Ballpen Black', 'Pens', 'Amspec Fine Products Inc.', 300, 12.00),
('7L5T9B', 'Faber-Castell Ballpen Blue', 'Pens', 'Amspec Fine Products Inc.', 280, 12.00),
('H2P6N4', 'Panda Ballpoint Pen Black', 'Pens', 'Goldwings Stationery Products Inc.', 500, 6.00),
('E9X1K3', 'Panda Ballpoint Pen Blue', 'Pens', 'Goldwings Stationery Products Inc.', 450, 6.00),



-- [ MARKERS ] (6)

('Markers', 'Highlighter Yellow', 'Markers', 'Goldwings Stationery Products Inc.', 110, 25.00),
('4W8J2R', 'Highlighter Green', 'Markers', 'Goldwings Stationery Products Inc.', 85, 25.00),
('T7M3L9', 'Highlighter Pink', 'Markers', 'Goldwings Stationery Products Inc.', 95, 25.00),
('2B6V8K', 'Whiteboard Marker Black', 'Markers', 'Penline Stationery Inc.', 70, 40.00),
('Y1Q5F4', 'Whiteboard Marker Blue', 'Markers', 'Penline Stationery Inc.', 65, 40.00),
('6N9P3X', 'Whiteboard Marker Black', 'Markers', 'Penline Stationery Inc.', 70, 40.00),
('F8W2D7', 'Permanent Marker Black', 'Markers', 'Penline Stationery Inc.', 130, 35.00),





-- [ NOTEBOOKS ] (6)
('9X4R6T', 'Spiral Notebook 80 Sheets', 'Notebooks', 'Sterling Paper Products Enterprises, Inc.', 200, 30.00),
('2M8B1K', 'Composition Notebook 80 Sheets', 'Notebooks', 'Sterling Paper Products Enterprises, Inc.', 180, 28.00),
('L7F3W9', 'Writing Notebook 80 Sheets', 'Notebooks', 'Sterling Paper Products Enterprises, Inc.', 220, 25.00),
('K5P9J2', 'Binder Notebook Filler', 'Notebooks', 'Capitol Stationery Mfg. Co. Inc.', 90, 45.00),
('3Q1V8D', 'Graphing Notebook', 'Notebooks', 'Sterling Paper Products Enterprises, Inc.', 110, 35.00),
('R6N7H4', 'Steno Notebook', 'Notebooks', 'Capitol Stationery Mfg. Co. Inc.', 85, 22.00),




-- [ PAPERS ] (6)
('5J9X3P', 'Short Bond Paper 70gsm (Ream)', 'Papers', 'Sterling Paper Products Enterprises, Inc.', 50, 210.00),
('B2L8R7', 'Long Bond Paper 70gsm (Ream)', 'Papers', 'Sterling Paper Products Enterprises, Inc.', 45, 230.00),
('8F4W1K', 'A4 Bond Paper 70gsm (Ream)', 'Papers', 'Sterling Paper Products Enterprises, Inc.', 60, 220.00),
('N7Q6D3', 'Intermediate Pad Paper', 'Capitol Stationery Mfg. Co. Inc.', 140, 35.00),
('P1V9M2', 'Intermediate Pad Paper', 'Papers', 'Capitol Stationery Mfg. Co. Inc.', 160, 40.00),
('X3T5J8', 'Construction Paper Assorted 20s', 'Papers', 'Goldwings Stationery Products Inc.', 75, 55.00),


-- [ MEASURING TOOLS ] (4)

('7W3M9F ', 'Plastic Ruler 12 Inch', 'Measuring Tools', 'Goldwings Stationery Products Inc.', 150, 15.00),
('D8P1K4 ', 'Metal Ruler 12 Inch', 'Measuring Tools', 'Goldwings Stationery Products Inc.', 90, 35.00),
('1Q6V2T', 'Math Protractor 180 Deg ', 'Measuring Tools', 'Goldwings Stationery Products Inc.', 110, 18.00),
('M5R8J7', 'Compass Set with Pencil', 'Measuring Tools', 'Penline Stationery Inc.', 70, 45.00),


-- [ ADHESIVES ] (4)


('2F9T6R', 'Elmer Glue 130ml', 'Adhesives', 'Amspec Fine Products Inc.', 85, 50.00),
('W4M1K8', 'Glue Stick 15g', 'Adhesives', 'Goldwings Stationery Products Inc.', 140, 25.00),
('7X8J3L', 'Transparent Tape 1 Inch', 'Adhesives', 'Goldwings Stationery Products Inc.', 120, 20.00),
('9P5B2V', 'Double Sided Tape 1 Inch', 'Adhesives', 'Goldwings Stationery Products Inc.', 95, 30.00),




-- [ CUTTING & CORRECTION ] (5)


('L4P8V2 ', 'Student Scissors 5 Inch', 'Cutting & Correction', 'Goldwings Stationery Products Inc.', 105, 28.00),
('8M3R7T', 'Cutter Knife Small  ', 'Cutting & Correction', 'Goldwings Stationery Products Inc.', 80, 22.00),
('1K9X5F ', 'Double Pencil Sharpener', 'Cutting & Correction', 'Amspec Fine Products Inc.', 130, 18.00),
('6J2N8W ', 'Correction Tape 12m', 'Cutting & Correction', 'Penline Stationery Inc.', 115, 38.00),
('T5Q1D9 ', 'Eraser White Large', 'Cutting & Correction', 'Amspec Fine Products Inc.', 210, 12.00),



-- [ ART SUPPLIES ] (3)



('Q8X2N7', 'Crayola Crayons 24 Colors', 'Art Supplies', 'Amspec Fine Products Inc.', 95, 90.00),
('4T7P1M', 'Watercolor Set 12 Colors', 'Art Supplies', 'Amspec Fine Products Inc.', 50, 110.00),
('9R5W3J ', 'Oil Pastels 12 Colors', 'Art Supplies', 'Amspec Fine Products Inc.', 65, 80.00),




-- [ OFFICE & STORAGE ] (3)

('3W9K6D', 'Expanding Clear Envelope Long', 'Office & Storage', 'Capitol Stationery Mfg. Co. Inc.', 140, 25.00),
('P8R4T1', 'Two-Hole Puncher Small', 'Office & Storage', 'Goldwings Stationery Products Inc.', 40, 85.00),
('7J1V5M', 'Heavy Duty Stapler with Staples', 'Office & Storage', 'Goldwings Stationery Products Inc.', 30, 150.00);



GO
