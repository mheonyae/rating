/*
' Copyright (c) 2019 matejrek
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Mr.Modules.Memeometer.Models
{
    [TableName("Memeometer_Item_Ratings")]
    //setup the primary key for table
    [PrimaryKey("ItemRatingId", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("ItemRatings", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class ItemRating
    {
        ///<summary>
        /// The ID of your object
        ///</summary>
        public int ItemId { get; set; } = -1;
        ///<summary>
        /// Item FK
        ///</summary>
        public int ItemIdFk { get; set; }

        ///<summary>
        /// A string with PC identity
        ///</summary>
        public string PcIdentity { get; set; }

        public int ItemRatingPoint {get; set; }


    }
}
