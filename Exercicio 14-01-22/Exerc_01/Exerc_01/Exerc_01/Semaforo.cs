using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_01
{
    class Semaforo
	{
		private byte estado;
		
		public Semaforo()
		{
			// com rua1 = vd e rua2 = vm - situação inicial
			this.estado = 129;
		}

		public void setVerde(int rua)
		{
			if (rua == 1)
			{
				this.estado = (byte)((int)(this.estado) & 248);
				this.estado = (byte)((int)(this.estado) | 1);
			}
			else
			{
				this.estado = (byte)((int)(this.estado) & 31);
				this.estado = (byte)((int)(this.estado) | 32);
			}
		}

		public void setAmarelo(int rua)
		{
			if (rua == 1)
			{
				this.estado = (byte)((int)(this.estado) & 248);
				this.estado = (byte)((int)(this.estado) | 2);
			}
			else
			{
				this.estado = (byte)((int)(this.estado) & 31);
				this.estado = (byte)((int)(this.estado) | 64);
			}
		}

		public void setVermelho(int rua)
		{
			if (rua == 1)
			{
				this.estado = (byte)((int)(this.estado) & 248);
				this.estado = (byte)((int)(this.estado) | 4);
			}
			else
			{
				this.estado = (byte)((int)(this.estado) & 31);
				this.estado = (byte)((int)(this.estado) | 128);
			}
		}

		public byte getEstado()
		{
			return this.estado;
		}

		public int getEstado(int rua)
		{
			// 1. Vd - 2. Am - 3. Vm
			byte aux = 0;
			int potencia = rua - 1;
			aux = (byte)((int)this.estado & (int)Math.Pow(2, potencia));
			return aux;
		}

		}
}
