using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    internal class Muayeneİslemleri_DIP_2132
    {
            internal interface IMuayeneGoruntuleme_2132
            {
                void MuayeneGoruntule(int hastaId);
            }

            internal interface IMuayeneIptalEtme_2132
            {
                void MuayeneIptalEt(int muayeneId);
            }

            internal interface IMuayeneSevkEtme_2132
            {
                void MuayeneSevkEt(int muayeneId, int yeniKlinikId);
            }

            internal interface IMuayeneIslem_2132 : IMuayeneGoruntuleme_2132, IMuayeneIptalEtme_2132, IMuayeneSevkEtme_2132
            {
            }

            internal class MuayeneServisi
            {
                private readonly IMuayeneIslem_2132 _muayeneIslem;

                public MuayeneServisi(IMuayeneIslem_2132 muayeneIslem)
                {
                    _muayeneIslem = muayeneIslem;
                }

                public void MuayeneGoruntule(int hastaId)
                {
                    _muayeneIslem.MuayeneGoruntule(hastaId);
                }

                public void MuayeneIptalEt(int muayeneId)
                {
                    _muayeneIslem.MuayeneIptalEt(muayeneId);
                }

                public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
                {
                    _muayeneIslem.MuayeneSevkEt(muayeneId, yeniKlinikId);
                }
            }
        }
    }