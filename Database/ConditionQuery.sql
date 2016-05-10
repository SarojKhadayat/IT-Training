Create Procedure Sp_CheckById 
(
@Id int
)
as
Begin
if(@Id=1)
Begin
Print 'I am computer'
End
Else If(@Id=2)
Begin
Print 'I am Civil'
End
Else If(@Id=3)
Begin
Print 'I am Electronics'
End
Else
Begin
print 'No category found Related to this ID= '+ cast(@Id as nvarchar(30))
End
ENd


select * from Student where Name in ('Niraj','Amrita')
select * from Student where Name like 's%'