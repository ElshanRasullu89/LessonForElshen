namespace LessonForElshen.RequestTypes
{
    public class EntitiRequest
    {
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        // silinmə tarixi lazım ossa baxacux
        public DateTime DeleteTime { get; set; }
    }
}
