SELECT * FROM Cart WHERE Account_ID = 11

SELECT COUNT(*) FROM Orders;

SELECT TOP 1 * FROM Orders ORDER BY OrderID DESC

SELECT * FROM Cart WHERE Account_ID = 11 AND Product_Status = 'Active' AND Cart_Status = 'Pending'

UPDATE Cart SET Cart_Status = NULL WHERE Account_Id = 11 AND Product_Status = 'Active' 