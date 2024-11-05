namespace AoTTG2_Custom_Logic;

/// <summary>
/// Base Struct needed for the Keyword "function"
/// </summary>
// public class function : Task
// {
//     public function(Action action) : base(action)
//     {
//     }
//
//     public function(Action action, CancellationToken cancellationToken) : base(action, cancellationToken)
//     {
//     }
//
//     public function(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, cancellationToken, creationOptions)
//     {
//     }
//
//     public function(Action action, TaskCreationOptions creationOptions) : base(action, creationOptions)
//     {
//     }
//
//     public function(Action<object?> action, object? state) : base(action, state)
//     {
//     }
//
//     public function(Action<object?> action, object? state, CancellationToken cancellationToken) : base(action, state, cancellationToken)
//     {
//     }
//
//     public function(Action<object?> action, object? state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, state, cancellationToken, creationOptions)
//     {
//     }
//
//     public function(Action<object?> action, object? state, TaskCreationOptions creationOptions) : base(action, state, creationOptions)
//     {
//     }
//     
// }

public class function<T> : Task
{
    public function(Action action) : base(action)
    {
    }

    public function(Action action, CancellationToken cancellationToken) : base(action, cancellationToken)
    {
    }

    public function(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, cancellationToken, creationOptions)
    {
    }

    public function(Action action, TaskCreationOptions creationOptions) : base(action, creationOptions)
    {
    }

    public function(Action<object?> action, object? state) : base(action, state)
    {
    }

    public function(Action<object?> action, object? state, CancellationToken cancellationToken) : base(action, state, cancellationToken)
    {
    }

    public function(Action<object?> action, object? state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(action, state, cancellationToken, creationOptions)
    {
    }

    public function(Action<object?> action, object? state, TaskCreationOptions creationOptions) : base(action, state, creationOptions)
    {
    }

   
}

public class function
{
    
}



