namespace cgptWebAPITest.Models
{
    public class DocumentSection
    {
        public required int Id { get; set; }

        // ドキュメントに一意の識別子
        public required string DocumentId { get; set; }

        // セクションに一意の識別子
        public required string SectionId { get; set; }

        // セクションのタイトル
        public required string Title { get; set; }

        // セクションの内容
        public required string Content { get; set; }

        // セクションの開始ページ
        public required int StartPage { get; set; }

        // セクションの終了ページ
        public required int EndPage { get; set; }

        // セクションのエンベディング
        public required string Embedding { get; set; }
    }
}
