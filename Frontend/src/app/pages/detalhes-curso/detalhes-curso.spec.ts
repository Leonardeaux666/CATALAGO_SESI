import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DetalhesCurso } from './detalhes-curso';

describe('DetalhesCurso', () => {
  let component: DetalhesCurso;
  let fixture: ComponentFixture<DetalhesCurso>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DetalhesCurso],
    }).compileComponents();

    fixture = TestBed.createComponent(DetalhesCurso);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
