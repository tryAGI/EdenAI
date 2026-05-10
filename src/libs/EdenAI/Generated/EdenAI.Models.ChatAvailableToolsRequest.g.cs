
#nullable enable

namespace EdenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAvailableToolsRequest
    {
        /// <summary>
        /// The name of your tool/function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The tool's parameters are specified using a JSON Schema object. Detailed format documentation is available in the [JSON Schema reference](https://json-schema.org/understanding-json-schema/).<br/>
        /// **Make sure to well describe each parameter for best results.**<br/>
        /// Example for a weather tool:<br/>
        ///     {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "location": {<br/>
        ///           "type": "string"<br/>
        ///           "description": "The geographical location for which weather data is requested."<br/>
        ///         },<br/>
        ///         "unit": {<br/>
        ///           "type": "string", "enum": ["Celsius", "Fahrenheit"]<br/>
        ///           "description": "The unit of measurement for temperature."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["location"]<br/>
        ///     }<br/>
        ///     
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAvailableToolsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of your tool/function
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters">
        /// The tool's parameters are specified using a JSON Schema object. Detailed format documentation is available in the [JSON Schema reference](https://json-schema.org/understanding-json-schema/).<br/>
        /// **Make sure to well describe each parameter for best results.**<br/>
        /// Example for a weather tool:<br/>
        ///     {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "location": {<br/>
        ///           "type": "string"<br/>
        ///           "description": "The geographical location for which weather data is requested."<br/>
        ///         },<br/>
        ///         "unit": {<br/>
        ///           "type": "string", "enum": ["Celsius", "Fahrenheit"]<br/>
        ///           "description": "The unit of measurement for temperature."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["location"]<br/>
        ///     }<br/>
        ///     
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAvailableToolsRequest(
            string? name,
            string? description,
            object? parameters)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAvailableToolsRequest" /> class.
        /// </summary>
        public ChatAvailableToolsRequest()
        {
        }

    }
}