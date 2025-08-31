namespace Project48.DataModels
{
    /// <summary>
    /// Defines a contract for converting one data model type to another.
    /// </summary>
    /// <typeparam name="TSource">The source data model type.</typeparam>
    /// <typeparam name="TDestination">The destination data model type.</typeparam>
    public interface IDataModelConverter<TSource, TDestination>
    {
        /// <summary>
        /// Converts an instance of <typeparamref name="TSource"/> to <typeparamref name="TDestination"/>.
        /// </summary>
        /// <param name="source">The source data model instance.</param>
        /// <returns>The converted destination data model instance.</returns>
        TDestination Convert(TSource source);
    }
}