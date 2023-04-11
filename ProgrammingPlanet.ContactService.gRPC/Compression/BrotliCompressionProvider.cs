namespace ProgrammingPlanet.ContactService.gRPC.Compression;

public class BrotliCompressionProvider : ICompressionProvider
{
    private readonly CompressionLevel? _level;

    public BrotliCompressionProvider(CompressionLevel? level) => _level = level;

    public string EncodingName => "br";

    public Stream CreateCompressionStream(Stream stream, CompressionLevel? compressionLevel)
    {
        if (_level.HasValue)
        {
            return new BrotliStream(stream, _level ?? compressionLevel!.Value, true);
        }
        else if (!_level.HasValue && compressionLevel.HasValue)
        {
            return new BrotliStream(stream, compressionLevel.Value, true);
        }
        return new BrotliStream(stream, CompressionLevel.Fastest, true);
    }

    public Stream CreateDecompressionStream(Stream stream) => new BrotliStream(stream, CompressionMode.Decompress);
}
