export interface Curso {
  id: number;
  nomeCompleto: string;
  nomeBreve: string;
  descricao: string;
  categoria: string;
  modalidade: string;
  cargaHoraria: number;
  publicoAlvo: string;
  status: string;
  imagemUrl: string;
  dataDisponibilizacao?: string; 
}