import { Component, OnInit, signal } from '@angular/core'; // <-- Importando o signal
import { CommonModule } from '@angular/common';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { CursoService } from '../../services/curso';
import { Curso } from '../../models/curso';

@Component({
  selector: 'app-detalhes-curso',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './detalhes-curso.html',
  styleUrl: './detalhes-curso.css'
})
export class DetalhesCurso implements OnInit {
  // Usando Signal para o curso
  curso = signal<Curso | undefined>(undefined);

  constructor(
    private route: ActivatedRoute,
    private cursoService: CursoService
  ) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.cursoService.getCursos().subscribe({
      next: (cursos) => {
        const cursoEncontrado = cursos.find(c => c.id === id);
        this.curso.set(cursoEncontrado); // <-- Atualiza o Signal
      },
      error: (erro) => console.error('Erro ao buscar curso:', erro)
    });
  }
}