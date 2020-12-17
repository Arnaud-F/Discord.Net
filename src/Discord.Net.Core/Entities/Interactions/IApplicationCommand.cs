using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
    /// <summary>
    /// The base command model that belongs to an application. see <see href="https://discord.com/developers/docs/interactions/slash-commands#applicationcommand"/>
    /// </summary>
    public interface IApplicationCommand : ISnowflakeEntity
    {
        /// <summary>
        /// Gets the unique id of the command
        /// </summary>
        ulong Id { get; }

        /// <summary>
        /// Gets the unique id of the parent application
        /// </summary>
        ulong ApplicationId { get; }

        /// <summary>
        /// The name of the command
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of the command
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Modifies this command
        /// </summary>
        /// <param name="func">The delegate containing the properties to modify the command with.</param>
        /// <param name="options">The options to be used when sending the request.</param>
        /// <returns>
        ///     A task that represents the asynchronous modification operation.
        /// </returns>
        Task ModifyAsync(Action<ApplicationCommandProperties> func, RequestOptions options = null);

        IEnumerable<IApplicationCommandOption>? Options { get; }
    }
}
