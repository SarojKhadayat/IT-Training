create procedure sp_Transaction
as
Begin
      Begin Try
          Begin Transaction
		  --Block of update/create/delete Codes
		  Commit Transaction
		  print 'Transaction Committed'
       End Try
      Begin Catch
	       Rollback Transaction
	       print 'Transaction Rolled Back'
	  End Catch
End

--to read uncommited data
--Set transaction isolation level read uncommitted