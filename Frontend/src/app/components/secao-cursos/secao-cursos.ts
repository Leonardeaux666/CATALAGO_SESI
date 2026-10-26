import { Component, OnInit, signal } from '@angular/core'; 
import { CommonModule } from '@angular/common';
import { CardCurso } from '../card-curso/card-curso';
import { Curso } from '../../models/curso';
import { CursoService } from '../../services/curso';

@Component({
  selector: 'app-secao-cursos',
  standalone: true,
  imports: [CommonModule, CardCurso],
  templateUrl: './secao-cursos.html',
  styleUrl: './secao-cursos.css'
})
export class SecaoCursos implements OnInit {
 
  listaCursos = signal<Curso[]>([]);
  carregando = signal<boolean>(true);

  constructor(private cursoService: CursoService) {}

  ngOnInit(): void {
    this.cursoService.getCursos().subscribe({
      next: (dados) => {
        this.listaCursos.set(dados); 
        this.carregando.set(false);  
        console.log('Cursos recebidos:', this.listaCursos());
      },
      error: (erro) => {
        this.carregando.set(false);
        console.error('Erro ao buscar cursos:', erro);
      }
    });
  }
}