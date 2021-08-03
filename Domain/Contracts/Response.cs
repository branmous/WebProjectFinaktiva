namespace Domain.Contracts
{
    public class Response<T>
    {
        public Header Header { get; set; }

        public T Data { get; set; }

        public Response()
        {
            Header = new Header();
            Header.Code = 200;
        }
    }

    public class Header
    {
        public int Code { get; set; }

        public string Message { get; set; }
    }
}
