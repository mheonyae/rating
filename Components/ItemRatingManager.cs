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
using System.Collections.Generic;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using Mr.Modules.Memeometer.Models;

namespace Mr.Modules.Memeometer.Components
{
    interface IItemRatingManager
    {
        void Upvote(ItemRating t);
    }

    class ItemRatingManager : ServiceLocator<IItemRatingManager, ItemRatingManager>, IItemRatingManager
    {

        public void Upvote(ItemRating t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<ItemRating>();
                rep.Insert(t);
            }
        }

        protected override Func<IItemRatingManager> GetFactory()
        {
            throw new NotImplementedException();
        }
    }
}
