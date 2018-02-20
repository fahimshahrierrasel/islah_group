CREATE PROCEDURE SP_InsertNewInvest
(
  @InvestorId INT,
  @UserId INT,
  @InvestDate DATE,
  @Amount DECIMAL(10, 2),
  @Profit DECIMAL(5, 2),
  @Note VARCHAR(400),
  @Type VARCHAR(30)
)
AS
BEGIN

  INSERT INTO Invest(Amount, Profit, InvestDate, Note, InvestType_Type, Investor_InvId, IGUser_UserId)
    VALUES (@Amount, @Profit, @InvestDate, @Note, @Type, @InvestorId, @UserId);

END
GO