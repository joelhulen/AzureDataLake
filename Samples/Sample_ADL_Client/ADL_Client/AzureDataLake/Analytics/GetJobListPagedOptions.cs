namespace AzureDataLake.Analytics
{

    public class GetJobListPagedOptions
    {
        public int Top = 1000;
        public JobOrderByField OrderByField;
        public JobOrderByDirection OrderByDirection;
    }
}