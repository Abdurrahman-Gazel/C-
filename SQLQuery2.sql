--select
select ContactName adi ,CompanyName sirketadi,City sehir from Customers

select * from Customers where City = 'Berlin'


select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 1 

select * from Products order by UnitPrice desc --ascending --descending

select count(*) adet from Products where CategoryID= 2 

select categoryID ,count(*) adet from Products group by CategoryID 

select categoryID ,count(*) adet from Products group by CategoryID having count(*)<10

select categoryID ,count(*) adet from Products where UnitPrice>20 group by CategoryID having count(*)<10



select * from Products inner join Categories 
oN Products.categoryID= Categories.categoryID



select Products.ProductID , Products.ProductName , Products.UnitPrice , Categories.CategoryName 
from Products inner join Categories 
oN Products.categoryID= Categories.categoryID

where Products.UnitPrice>50

--DTO Data transformation object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

inner join Orders o 
on o.OrderID = od.OrderID


select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null 
