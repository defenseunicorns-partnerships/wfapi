using Amazon.S3;

namespace wfapi;

/// <summary>
/// Static S3 configuration
/// </summary>
public class S3Client
{
    /// <summary>
    /// Create a new S3 client
    /// </summary>
    /// <param name="bucketName"></param>
    /// <param name="s3Client"></param>
    public S3Client(string bucketName, IAmazonS3 s3Client)
    {
        this.BucketName = bucketName;
        this.Client = s3Client;
    }

    /// <summary>
    /// The bucket name to use for all operations
    /// </summary>
    public string BucketName { get; }

    /// <summary>
    /// The S3 client to use for all operations
    /// </summary>
    public IAmazonS3 Client { get; }
}
