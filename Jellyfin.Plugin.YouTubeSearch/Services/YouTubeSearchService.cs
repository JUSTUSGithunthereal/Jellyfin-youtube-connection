namespace Jellyfin.Plugin.YouTubeSearch.Services;

public class YouTubeSearchService
{
    public Task<List<string>> SearchAsync(string query)
    {
        return Task.FromResult(new List<string>
        {
            "Video 1: " + query,
            "Video 2: " + query
        });
    }
}
