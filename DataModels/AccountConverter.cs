using Project48.QfxDataModels;

namespace Project48.DataModels
{
    /// <summary>
    /// Converts a <see cref="BankAcctFrom"/> model from QfxDataModels to a <see cref="Account"/> model in DataModels.
    /// </summary>
    /// <remarks>
    /// This converter maps all available properties from BankAcctFrom. Properties not present in BankAcctFrom are set to default values.
    /// </remarks>
    public class AccountConverter : IDataModelConverter<BankAcctFrom, Account>
    {
        /// <summary>
        /// Converts a <see cref="BankAcctFrom"/> instance to an <see cref="Account"/> instance.
        /// </summary>
        /// <param name="source">The source <see cref="BankAcctFrom"/> object.</param>
        /// <returns>A new <see cref="Account"/> object with mapped properties.</returns>
        public Account Convert(BankAcctFrom source)
        {
            return new Account
            {
                AcctId = Guid.NewGuid(),
                Name = $"{source.ACCTID} - {source.ACCTTYPE}",
                Description = source.ACCTTYPE,
                AcctType = source.ACCTTYPE,
                StartingBalance = 0m,
                ReserveAmount = 0m,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                ExtAcctId = source.ACCTID,
                ExtBankId = source.BANKID,
                Balance = 0m
            };
        }
    }
}