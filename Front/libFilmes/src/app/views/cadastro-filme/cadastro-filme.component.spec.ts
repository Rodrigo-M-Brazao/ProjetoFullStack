import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroFilmeComponent } from './cadastro-filme.component';

describe('CadastroFilmeComponent', () => {
  let component: CadastroFilmeComponent;
  let fixture: ComponentFixture<CadastroFilmeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroFilmeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastroFilmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
