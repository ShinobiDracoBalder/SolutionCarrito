using System.Collections.Generic;

namespace Library.Common.Responses
{
    public class Response<TObject>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public int TruePasswordHash { get; set; }
        public TObject Object { get; set; }
        public List<TObject> ObjectLists { get; set; }
    }
}
