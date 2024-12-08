using OopPhotoBookClass;

internal class Program
{
    private static void Main(string[] args)
    {
        PhotoBook photoBook = new PhotoBook();
        Console.WriteLine($"Page : {photoBook.GetNumberPages()}");

        PhotoBook photoBook1 = new PhotoBook(24);
        Console.WriteLine($"Page : {photoBook1.GetNumberPages()}");

        BigPhotoBook bigPhotoBook = new BigPhotoBook();
        Console.WriteLine($"Page : {bigPhotoBook.GetNumberPages()}");
    }
}