namespace Project48.DataModels
{
    /// <summary>
    /// Defines a contract for importing and parsing several QFX files into a Database object.
    /// </summary>
    public interface IDatabaseImporter
    {
        /// <summary>
        /// Scans and parses the given QFX files, returning a populated Database object.
        /// </summary>
        /// <param name="filePaths">Paths to QFX files to import.</param>
        /// <returns>A Database object containing parsed data.</returns>
        Database ImportFromFiles(IEnumerable<string> filePaths);
    }
}
