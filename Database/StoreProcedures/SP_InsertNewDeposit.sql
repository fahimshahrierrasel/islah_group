ALTER PROCEDURE dbo.SP_InsertNewDeposit (@DepositDate DATE,
@Amount DECIMAL(10, 2),
@Note VARCHAR(300),
@MemberId INT,
@UserId INT)
AS
BEGIN

  DECLARE @CurrentMemberAmount DECIMAL(10, 2);
  DECLARE @UpdatedMemberAmount DECIMAL(10, 2);
  DECLARE @CurrentCapital DECIMAL(12, 2);
  DECLARE @UpdatedCapital DECIMAL(12, 2);
  DECLARE @CurrentTotalDeposit DECIMAL(14, 2);
  DECLARE @UpdatedTotalDeposit DECIMAL(14, 2);

  SELECT
    @CurrentMemberAmount = MemberAmount.Amount
  FROM MemberAmount
  WHERE MemberAmount.IGMember_MemberId = @MemberId;

  SELECT
    @CurrentCapital = Capital.CurrentAmount
   ,@CurrentTotalDeposit = Capital.TotalDeposit
  FROM Capital
  WHERE Capital.CapitalId = 1;

  INSERT INTO MemberDeposit (DepositDate,
  Amount,
  Note,
  IGMember_MemberId,
  IGUser_UserId)
    VALUES (@DepositDate, @Amount, @Note, @MemberId, @UserId)

  SET @UpdatedMemberAmount = @CurrentMemberAmount + @Amount;
  SET @UpdatedCapital = @CurrentCapital + @Amount;
  SET @UpdatedTotalDeposit = @CurrentTotalDeposit + @Amount;

  UPDATE MemberAmount
  SET Amount = @UpdatedMemberAmount
  WHERE IGMember_MemberId = @MemberId;
  UPDATE Capital
  SET CurrentAmount = @UpdatedCapital
     ,TotalDeposit = @UpdatedTotalDeposit
  WHERE CapitalId = 1;

END
GO