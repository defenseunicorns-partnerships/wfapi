namespace wfapi.V1.Models;

/// <summary>
/// WorkflowStatus enum
/// </summary>
public enum WorkflowStatus
{
    /// <summary>
    /// The workflow has been submitted but has not started yet
    /// </summary>
    Pending,

    /// <summary>
    /// The workflow has been started and is currently running
    /// </summary>
    Running,

    /// <summary>
    /// The workflow completed successfully
    /// </summary>
    Succeeded,

    /// <summary>
    /// The workflow completed but failed
    /// </summary>
    Failed,

    /// <summary>
    /// An error occurred. Check the message field in the WorkflowInfo object for more information
    /// </summary>
    Error
}
