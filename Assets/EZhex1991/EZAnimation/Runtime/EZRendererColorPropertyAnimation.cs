/* Author:          ezhex1991@outlook.com
 * CreateTime:      2019-08-01 19:02:30
 * Organization:    #ORGANIZATION#
 * Description:     
 */
using UnityEngine;

namespace EZhex1991.EZAnimation
{
    public class EZRendererColorPropertyAnimation : EZAnimation<Renderer, EZColorSegment>
    {
        [SerializeField]
        private string m_PropertyName = "_Color";
        public string propertyName { get { return m_PropertyName; } }

        private MaterialPropertyBlock m_PropertyBlock;
        private MaterialPropertyBlock propertyBlock
        {
            get
            {
                if (m_PropertyBlock == null)
                    m_PropertyBlock = new MaterialPropertyBlock();
                return m_PropertyBlock;
            }
        }

        protected override void OnSegmentUpdate()
        {
            target.GetPropertyBlock(propertyBlock);
            propertyBlock.SetColor(propertyName, activeSegment.Evaluate(segmentProcess));
            target.SetPropertyBlock(propertyBlock);
        }
    }
}
