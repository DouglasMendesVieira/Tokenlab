import { RedeSocial } from './RedeSocial';
import { Lote } from "./Lote";
import { Palestrante } from './Palestrante';

export interface Evento {
  id: number;
  tema: string;
  descricao: string;
  local: string;
  dataEvento?: Date;
  horaInicio: string;
  horaTermino: string;
  qtdPessoas: number;
  imagemURL: string;
  telefone: string;
  email: string;
  lotes: Lote[];
  redesSociais: RedeSocial[];
  palestrantesEventos: Palestrante[];
}
