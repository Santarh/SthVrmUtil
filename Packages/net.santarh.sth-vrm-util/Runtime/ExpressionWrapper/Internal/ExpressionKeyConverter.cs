using System;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal static class ExpressionKeyConverter
    {
        public static ExpressionKey ToVrm10(this BlendShapeKey key)
        {
            switch (key.Preset)
            {
                case BlendShapePreset.Unknown: return ExpressionKey.CreateCustom(key.Name);
                case BlendShapePreset.Neutral: return ExpressionKey.CreateFromPreset(ExpressionPreset.neutral);
                case BlendShapePreset.A: return ExpressionKey.CreateFromPreset(ExpressionPreset.aa);
                case BlendShapePreset.I: return ExpressionKey.CreateFromPreset(ExpressionPreset.ih);
                case BlendShapePreset.U: return ExpressionKey.CreateFromPreset(ExpressionPreset.ou);
                case BlendShapePreset.E: return ExpressionKey.CreateFromPreset(ExpressionPreset.ee);
                case BlendShapePreset.O: return ExpressionKey.CreateFromPreset(ExpressionPreset.oh);
                case BlendShapePreset.Blink: return ExpressionKey.CreateFromPreset(ExpressionPreset.blink);
                case BlendShapePreset.Joy: return ExpressionKey.CreateFromPreset(ExpressionPreset.happy);
                case BlendShapePreset.Angry: return ExpressionKey.CreateFromPreset(ExpressionPreset.angry);
                case BlendShapePreset.Sorrow: return ExpressionKey.CreateFromPreset(ExpressionPreset.sad);
                case BlendShapePreset.Fun: return ExpressionKey.CreateFromPreset(ExpressionPreset.relaxed);
                case BlendShapePreset.LookUp: return ExpressionKey.CreateFromPreset(ExpressionPreset.lookUp);
                case BlendShapePreset.LookDown: return ExpressionKey.CreateFromPreset(ExpressionPreset.lookDown);
                case BlendShapePreset.LookLeft: return ExpressionKey.CreateFromPreset(ExpressionPreset.lookLeft);
                case BlendShapePreset.LookRight: return ExpressionKey.CreateFromPreset(ExpressionPreset.lookRight);
                case BlendShapePreset.Blink_L:return ExpressionKey.CreateFromPreset(ExpressionPreset.blinkLeft);
                case BlendShapePreset.Blink_R: return ExpressionKey.CreateFromPreset(ExpressionPreset.blinkRight);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static BlendShapeKey ToVrm0X(this ExpressionKey key)
        {
            switch (key.Preset)
            {
                case ExpressionPreset.custom: return BlendShapeKey.CreateUnknown(key.Name);
                case ExpressionPreset.happy: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Joy);
                case ExpressionPreset.angry: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Angry);
                case ExpressionPreset.sad: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Sorrow);
                case ExpressionPreset.relaxed: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Fun);
                case ExpressionPreset.surprised: return BlendShapeKey.CreateUnknown("surprised");
                case ExpressionPreset.aa: return BlendShapeKey.CreateFromPreset(BlendShapePreset.A);
                case ExpressionPreset.ih: return BlendShapeKey.CreateFromPreset(BlendShapePreset.I);
                case ExpressionPreset.ou: return BlendShapeKey.CreateFromPreset(BlendShapePreset.U);
                case ExpressionPreset.ee: return BlendShapeKey.CreateFromPreset(BlendShapePreset.E);
                case ExpressionPreset.oh: return BlendShapeKey.CreateFromPreset(BlendShapePreset.O);
                case ExpressionPreset.blink: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Blink);
                case ExpressionPreset.blinkLeft: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Blink_L);
                case ExpressionPreset.blinkRight: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Blink_R);
                case ExpressionPreset.lookUp: return BlendShapeKey.CreateFromPreset(BlendShapePreset.LookUp);
                case ExpressionPreset.lookDown: return BlendShapeKey.CreateFromPreset(BlendShapePreset.LookDown);
                case ExpressionPreset.lookLeft: return BlendShapeKey.CreateFromPreset(BlendShapePreset.LookLeft);
                case ExpressionPreset.lookRight: return BlendShapeKey.CreateFromPreset(BlendShapePreset.LookRight);
                case ExpressionPreset.neutral: return BlendShapeKey.CreateFromPreset(BlendShapePreset.Neutral);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}