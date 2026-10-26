import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SecaoCursos } from './secao-cursos';

describe('SecaoCursos', () => {
  let component: SecaoCursos;
  let fixture: ComponentFixture<SecaoCursos>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SecaoCursos],
    }).compileComponents();

    fixture = TestBed.createComponent(SecaoCursos);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
