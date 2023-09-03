namespace SharedServices.Data
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class StreamSqlChangesAttribute : Attribute
    {
        public StreamSqlChangesAttribute() { }
    }
}
