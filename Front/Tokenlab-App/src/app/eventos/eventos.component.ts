import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos:any = [];
  public eventosFiltrados: any = [];

  widthImg = 160;
  marginImg = 2;
  showImg = true;
  private _filterList = '';

  public get filterList() {
    return this._filterList;
  }

  public set filterList(value: string) {
    this._filterList = value;
    this.eventosFiltrados = this.filterList ? this.filtrarEventos(this.filterList) : this.eventos;
  }

  filtrarEventos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento:any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  changeButtonImg() {
    this.showImg = !this.showImg
  }

  public getEventos():void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      responde => {
        this.eventos = responde,
        this.eventosFiltrados = this.eventos;
      },
      error => console.log(error)
    );
  }
}
