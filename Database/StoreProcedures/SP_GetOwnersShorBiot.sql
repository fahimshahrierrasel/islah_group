CREATE PROCEDURE SP_GetOwnersShortBio
  AS
  BEGIN

    SELECT
      IGMember.FullName
     ,IGMember.Designation
     ,IGMember.ImageUrl
    FROM dbo.IGMember
    WHERE IGMember.MemberType = 'Owner'

  END