using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Recomendation
    {
        public static bool CheckRecommendation(PostINSocialMedia post)
        {
            return post.Likes >= 2 * post.Dislikes;
        }
    }
}
