
select
p.ProductName,
c.CategoriName
from
Products p
left outer join ProductsCategories pc on pc.ProductId = p.ProductId
left outer join Categories c on c.CategoruId = pc.CategoryId