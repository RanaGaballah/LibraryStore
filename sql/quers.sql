use Library
/* First query*/
select  title as "Most Interesting Book"  ,  sold_copies as "Number Of Buyers"
from Document_
where sold_copies in 
(select max(sold_copies) from Document_)
/*second query*/
select title as "Book Title" from Document_ 
where sold_copies is null and month = 'may' 
 /*third query*/
 select count(author_name) as "Authors has no buyers" 
FROM Document_
where sold_copies is null and month = 'may'
/*fourth query*/
 select  AUname as "Author had not publish any book"
 from AUTHOR_ 
 where Bid is null
 
 /*fifth query*/
 select  Cname as "Category Name"  , Bnum as "Number Of Books"
from category
where Bnum in 
(select min(Bnum) from category)
 /*6th query*/
 select Rname as "Reader Name" ,
Remail as "Reader Email" ,
Rphone as "Reader Phone Number" ,
books_bought as "Number Of Books He/She Buy"
from reader_ 

