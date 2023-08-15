namespace AsuransiXYZ.Utility
{
    public class UtilityFunction
    {
        public static void MappingModel<TDest, TSource>(TDest destination, TSource source)
       where TDest : class
       where TSource : class
        {
            var destinationProperties = destination.GetType().GetProperties();
            var sourceProperties = source.GetType().GetProperties();
            foreach (var sourceProperty in sourceProperties)
            {
                var property = destinationProperties.FirstOrDefault(a => a.Name == sourceProperty.Name);
                if (property != null)
                {
                    property.SetValue(destination, sourceProperty.GetValue(source));
                }
            }
        }
    }
}