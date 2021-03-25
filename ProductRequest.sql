select pr.name cat.name from product as pr left join product_category as pc on pc.product = pr.id left join category as cat on pc.category = cat.id
