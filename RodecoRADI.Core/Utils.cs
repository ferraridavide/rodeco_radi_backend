using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RodecoRADI.Core
{
    public static class Utils
    {
        public static Guid ParseGuidOrNew(string guid)
        {
            if (Guid.TryParse(guid, out Guid validGuid))
            {
                return validGuid;
            }
            else
            {
                return Guid.NewGuid();
            }
        }

        public static TObject Overlay<TObject>(this TObject source, TObject overlay)
        {
            foreach (var prop in typeof(TObject).GetProperties().Where(x => x.CanWrite && x.CanRead && !x.IsDefined(typeof(OverlayIgnoreAttribute))))
            {
                var value = prop.GetValue(overlay, null);
                if (value != null)
                {
                    prop.SetValue(source, value);
                }
            }
            return source;
        }

        public static void ProcessPhoto(this RodecoContext context, Photo photo)
        {
            if (photo.MarkAsDeleted)
            {
                context.Photos.Remove(photo);
                return;
            }
            var source = context.Photos.FirstOrDefault(x => x.Id == photo.Id);
            if (source is not null) {
                source.Overlay(photo);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class OverlayIgnoreAttribute : Attribute {}
}
