/* DocIntel
 * Copyright (C) 2018-2021 Belgian Defense, Antoine Cailliau
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

using Elasticsearch.Net;

using Newtonsoft.Json.Converters;

namespace DocIntel.Core.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Serializable]
    [StringEnum]
    public enum ObservableType
    {
        [Display(Name = "IPv4")] [EnumMember(Value = "ipv4-addr")]
        IPv4,

        [Display(Name = "Domain")] [EnumMember(Value = "domain-name")]
        FQDN,

        [Display(Name = "Url")] [EnumMember(Value = "url")]
        URL,

        [Display(Name = "File")] [EnumMember(Value = "file")]
        File,

        [Display(Name = "Artefact")] [EnumMember(Value = "artefact")]
        Artefact
    }
}