alter Procedure Sp_TestTransaction
as
Begin
   Begin Try
      Begin Transaction
	    Update Department
		set RelatedHOD=2 where Name='Civil'

		Update Department 
		set RelatedHOD = 1 where Name='Computer'
	  Commit Transaction
	  Print 'Trasaction Committed'
   End Try 
 Begin Catch
       Rollback Transaction
	   print 'Trasaction Rolledback'
 End Catch     
END



--Begin Transaction
--update Student 
--set Address='kalanki' where Name='Niraj'
--commit transaction
--Rollback Transaction
--select * from Student
--select * from Department