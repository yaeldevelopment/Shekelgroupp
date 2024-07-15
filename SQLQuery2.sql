select p.[ProductID],[ProductDesc], ISNULL(SUM(Quantity), 0) from [dbo].[Products] p left join [dbo].[Order Details] o
on o.ProductID=p.ProductID 
GROUP BY 
    p.ProductID, p.ProductDesc
ORDER BY 
    p.ProductID;