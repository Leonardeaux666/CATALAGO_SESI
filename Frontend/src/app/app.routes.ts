import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { DetalhesCurso } from './pages/detalhes-curso/detalhes-curso';

export const routes: Routes = [

  { path: '', component: Home, runGuardsAndResolvers: 'always' },
  { path: 'curso/:id', component: DetalhesCurso }
];