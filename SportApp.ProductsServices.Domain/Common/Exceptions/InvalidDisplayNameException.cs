namespace SportApp.ProductsServices.Domain.Common.Exceptions ;

    public class InvalidDisplayNameException(string value, string description, Type type) :
        BusinessException($"'{value}' is not a valid {description} in {type}");
