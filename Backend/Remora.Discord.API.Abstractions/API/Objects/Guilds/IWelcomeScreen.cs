//
//  IWelcomeScreen.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Collections.Generic;

namespace Remora.Discord.API.Abstractions.Objects
{
    /// <summary>
    /// Represents the welcome screen in a community-enabled server.
    /// </summary>
    public interface IWelcomeScreen
    {
        /// <summary>
        /// Gets the description shown in the welcome screen.
        /// </summary>
        string? Description { get; }

        /// <summary>
        /// Gets the channels shown in the welcome screen. May contain up to five channels at the time of
        /// implementation.
        /// </summary>
        IReadOnlyList<IWelcomeScreenChannel> WelcomeChannels { get; }
    }
}