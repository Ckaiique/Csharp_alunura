class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome {get;set;}
    public void AdiconarAlbum(Album album)
    {
        albums.Add(album);
    }
    
}