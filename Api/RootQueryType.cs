using HotChocolate.Types;

namespace Api
{
    public class RootQueryType : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field("foo").Type<StringType>().Resolver(ctx => "bar");
        }
    }
}
