#### [Portal](index.md 'index')
### [Nodify.StateMachine](Nodify.StateMachine.md 'Nodify.StateMachine').[BlackboardPropertyAttribute](BlackboardPropertyAttribute.md 'Nodify.StateMachine.BlackboardPropertyAttribute')

## BlackboardPropertyAttribute(string, BlackboardKeyType) Constructor

Properties decorated with this attribute must always be of type [Nodify.StateMachine.BlackboardProperty](https://docs.microsoft.com/en-us/dotnet/api/Nodify.StateMachine.BlackboardProperty 'Nodify.StateMachine.BlackboardProperty').

```csharp
public BlackboardPropertyAttribute(string? name, Nodify.StateMachine.BlackboardKeyType type=Nodify.StateMachine.BlackboardKeyType.Object);
```
#### Parameters

<a name='Nodify.StateMachine.BlackboardPropertyAttribute.BlackboardPropertyAttribute(string,Nodify.StateMachine.BlackboardKeyType).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The display name of the key.

<a name='Nodify.StateMachine.BlackboardPropertyAttribute.BlackboardPropertyAttribute(string,Nodify.StateMachine.BlackboardKeyType).type'></a>

`type` [Nodify.StateMachine.BlackboardKeyType](https://docs.microsoft.com/en-us/dotnet/api/Nodify.StateMachine.BlackboardKeyType 'Nodify.StateMachine.BlackboardKeyType')

The data type of the value that the key refers to.