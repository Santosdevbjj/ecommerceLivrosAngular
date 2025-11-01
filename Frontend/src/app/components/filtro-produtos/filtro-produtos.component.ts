import { Component } from '@angular/core';
import { ProdutoService } from '../../services/produto.service';
import { Produto } from '../../models/produto.model';

@Component({
  selector: 'app-filtro-produtos',
  templateUrl: './filtro-produtos.component.html',
  styleUrls: ['./filtro-produtos.component.css']
})
export class FiltroProdutosComponent {
  termo: string = '';
  resultados: Produto[] = [];

  constructor(private produtoService: ProdutoService) {}

  buscar(): void {
    if (this.termo.trim() === '') {
      this.resultados = [];
      return;
    }

    this.produtoService.getProdutos().subscribe(produtos => {
      this.resultados = produtos.filter(p =>
        p.titulo.toLowerCase().includes(this.termo.toLowerCase())
      );
    });
  }
}
