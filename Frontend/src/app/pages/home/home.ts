import { Component } from '@angular/core';
import { Hero } from '../../components/hero/hero';
import { SecaoCursos } from '../../components/secao-cursos/secao-cursos';
import { Impacto } from '../../components/impacto/impacto';
import { Depoimentos } from '../../components/depoimentos/depoimentos';
import { CtaFinal } from '../../components/cta-final/cta-final';
import { Footer } from '../../components/footer/footer';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [Hero, SecaoCursos, Impacto, Depoimentos, CtaFinal, Footer], // <-- Importante
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home { }