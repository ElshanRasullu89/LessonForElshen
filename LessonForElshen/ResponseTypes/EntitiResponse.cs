namespace LessonForElshen.ResponseTypes
{
    public class EntitiResponse
    {
      // lazım olsa buradan silinib silinmədiyinə baxacux
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
      // silinmə tarixi lazım ossa baxacux
        public DateTime DeleteTime { get; set; }
    }
}
