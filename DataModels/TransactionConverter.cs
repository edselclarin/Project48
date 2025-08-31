using Project48.Extenstions;
using Project48.QfxDataModels;

namespace Project48.DataModels
{
    /// <summary>
    /// Converts a <see cref="Project48.QfxDataModels.Transaction"/> from QfxDataModels to a <see cref="Project48.DataModels.Transaction"/>.
    /// </summary>
    /// <remarks>
    /// This converter maps transaction type, dates, amount, and other relevant fields. Some fields may require custom mapping or default values.
    /// </remarks>
    public class TransactionConverter : IDataModelConverter<Project48.QfxDataModels.Transaction, Project48.DataModels.Transaction>
    {
        /// <summary>
        /// Converts a QfxDataModels.Transaction to a DataModels.Transaction.
        /// </summary>
        /// <param name="source">The source QfxDataModels.Transaction object.</param>
        /// <returns>A new DataModels.Transaction object with mapped properties.</returns>
        public Project48.DataModels.Transaction Convert(Project48.QfxDataModels.Transaction source)
        {
            return new Project48.DataModels.Transaction
            {
                TrnsId = Guid.NewGuid(),
                Date = DateTime.TryParse(source.DTPOSTED, out var dt) ? dt : DateTime.MinValue,
                TrnsType = source.TRNTYPE,
                RefNum = source.NAME.ExtractNumber().ToString(),
                Payee = source.NAME,
                Memo = source.MEMO,
                State = string.Empty,
                Amount = source.TRNAMT,
                ExtTrnsId = source.FITID,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                AcctId = Guid.NewGuid(),
            };
        }
    }
}
